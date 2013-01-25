@echo on
@set CYGWIN=nodosfilewarning

@ipfw -q flush
@ipfw -q pipe flush
@echo ######################################################################
@echo ## Set Delay to 160 ms on all protocols frfom all to all source dest ##
@echo ######################################################################
ipfw pipe 3 config delay 160ms mask all
ipfw add pipe 3 ip from any to any
ipfw pipe show
pause

@echo #################
@echo ## Cleaning up ##
@echo #################
ipfw -q flush
ipfw -q pipe flush

pause
