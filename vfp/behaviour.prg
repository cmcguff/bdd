
DEFINE CLASS StaffBehaviour as Custom olepublic

	FUNCTION ChangeFormCaption(oObj as Form) as VOID 
		oObj.Caption = "New Form Caption"
	ENDFUNC 

ENDDEFINE