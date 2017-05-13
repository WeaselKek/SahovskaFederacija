
		list p=16f870		;list directive to define processor
		#include <p16f870.inc>	;processor specific definitions
		errorlevel -302		;suppress "not in bank 0" message
;		#include <makro.asm>		
		__CONFIG   _CP_OFF & _WDT_OFF & _BODEN_ON & _PWRTE_ON & _HS_OSC & _WRT_ENABLE_ON & _LVP_OFF & _CPD_OFF 


;----------------------------------------------------------------------------
;Constants


;----------------------------------------------------------------------------
;Variables

		CBLOCK	0x30
		CIFRA1
		CIFRA2
		BROJAC
		INDEKS
		WREG_TEMP		;storage for WREG during interrupt
		STATUS_TEMP		;storage for STATUS during interrupt
		PCLATH_TEMP		;storage for PCLATH during interrupt
		FSR_TEMP		;storage for FSR during interrupt
		
		ENDC
		
;----------------------------------------------------------------------------
;This code executes when a reset occurs.
		ORG 0x0000
		goto ResetCode
		ORG	0x0004		;place code at interrupt vector
		goto InterruptCode

ResetCode:	
		clrf    PCLATH		;select program memory page 0		
		goto	Start		;go to beginning of program
			
Dekodiranje:	
		ADDWF PCL,f	;PCL=PCL+W
		RETLW 0x7E
		RETLW 0x30
		RETLW 0x6D
		RETLW 0x79
		RETLW 0x33
		RETLW 0x5B
		RETLW 0x5F
		RETLW 0x70
		RETLW 0x7F
		RETLW 0x7B
		
delay:
		clrf BROJAC
delay2:		
		btfss INTCON,T0IF
		goto delay2
		return
    
		
Start:	
		banksel ADCON1
		movlw   0x06
		movwf   ADCON1
		
		banksel TRISA
		
		clrf	TRISA
		clrf	TRISB
		clrf	TRISC
		bsf	TRISB,7
		bsf	TRISA,2
		
		movlw	b'00000100'
		movwf	OPTION_REG
		
		movlw	b'10100000'
		movwf	INTCON
		
		clrf	CIFRA1
		clrf	CIFRA2
		clrf	BROJAC
		clrf	INDEKS
		
		banksel PORTB		

petlja:		
		btfss	PORTB,7
		call	uvecaj
		btfss	PORTA,2
		call	umanji
		goto	petlja

;Kod za inkrementiranje	
		
uvecaj:
		call	delay
		btfsc	PORTB,7	    ;skip if still zero
		return
		
		incf	CIFRA2,f
		movlw	.10
		subwf	CIFRA2,f    
		btfss	STATUS,Z    ;ako je C2==10 , setuj je na 0
		goto	kraj
		
		clrf	CIFRA2
		incf	CIFRA1,f
		movlw	.10
		subwf	CIFRA1,f
		btfsc	STATUS,Z    ;ako je C1==10, setuj je na 0
		clrf	CIFRA1
		goto	kraj
kraj:	
		btfss	PORTB,7
		goto	kraj
		call	delay
		btfss	PORTB,7
		goto	kraj
		return
	
;Kod za dekrementiranje		
		
umanji:
		call	delay
		btfsc	PORTA,2	    ;skip if still zero
		return
		
		movf	CIFRA2,f
		btfss	STATUS,Z    ;ako je cifra2 0 setuj je na 9
		goto	D1	    ;inace je samo dekrementiraj
		movlw	.9
		movwf	CIFRA2
		
		movf	CIFRA1,f
		btfss	STATUS,Z    ;ako je cifra1 0 setuj je na 9
		goto	D2	    ;inace je samo dekrementiraj
		movlw	.9
		movwf	CIFRA1
		
		goto	kraj2
		
D1:
		decf	CIFRA2,f
		goto	kraj2
D2:
		decf	CIFRA1,f
		goto	kraj2
kraj2:	
		btfss	PORTA,2
		goto	kraj2
		call	delay
		btfss	PORTA,2
		goto	kraj2
		return
    
		
		

;----------------------------------------------------------------------------
;This code executes when an interrupt occurs.

		
InterruptCode:	
		
		movwf	WREG_TEMP	;save WREG
		swapf	STATUS,W	;store STATUS in WREG
		clrf	STATUS		;select file register bank0
		movwf	STATUS_TEMP	;save STATUS value
		movf	PCLATH,W	;store PCLATH in WREG
		movwf	PCLATH_TEMP	;save PCLATH value
		clrf	PCLATH		;select program memory page0
		movf	FSR,W		;store FSR in WREG
		movwf	FSR_TEMP	;save FSR value

Upit:
		btfss	INTCON,T0IF
		goto	EndInt
ObradaTMR0:
		incf	INDEKS,f    ;INDEKS++
		movf	CIFRA2,w    ;CIFRA2 = W
		btfss	INDEKS,0    ;skipuje ako je 0-ti bit jednak 1
		movf	CIFRA1,w    ;CIFRA1 = W
		
		;0 je za osvezavanje C1 a 1 za C2
		
		call	Dekodiranje ;W = CIFRA1 OR CIFRA2
		
		movwf	PORTB	    ;PORTB = W
		btfsc	INDEKS,0    ;skipuje ako je 0-ti bit jednak 0
		goto	DC2
		
DC1:		
		BSF	PORTA,0
		BCF	PORTA,1
		goto	kraj3
DC2:
		BCF	PORTA,0
		BSF	PORTA,1
		goto	kraj3
kraj3:
		incf	BROJAC,f    ;?????
		BCF	INTCON,T0IF
		
	
		

;------------------------------------
;End of interrupt routine restores context

EndInt:		
		bcf	3,5		;select bank 0
		movf	FSR_TEMP,W	;get saved FSR value
		movwf	FSR		;restore FSR
		movf	PCLATH_TEMP,W	;get saved PCLATH value
		movwf	PCLATH		;restore PCLATH
		swapf	STATUS_TEMP,W	;get saved STATUS value
		movwf	STATUS		;restore STATUS
		swapf	WREG_TEMP,F	;prepare WREG to be restored
		swapf	WREG_TEMP,W	;restore WREG without affecting STATUS
		retfie			;return from interrupt

		end
