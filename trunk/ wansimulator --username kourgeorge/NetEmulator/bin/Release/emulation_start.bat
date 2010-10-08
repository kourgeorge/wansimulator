@set CYGWIN=nodosfilewarning
@ipfw -q flush
@ipfw -q pipe flush

ipfw pipe 1 config delay 0ms plr 0.02 mask all
ipfw pipe 2 config delay 0ms plr 0.02 mask all
ipfw add pipe 1 ip from any to any in
ipfw add pipe 2 ip from any to any out

