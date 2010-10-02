@set CYGWIN=nodosfilewarning
@ipfw -q flush
@ipfw -q pipe flush

ipfw pipe 1 config delay 0ms  mask all
ipfw add pipe 1 ip from any to any
ipfw pipe show
