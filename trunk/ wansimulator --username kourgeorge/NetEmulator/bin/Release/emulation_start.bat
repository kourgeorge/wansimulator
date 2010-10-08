@set CYGWIN=nodosfilewarning
@ipfw -q flush
@ipfw -q pipe flush
ipfw add 100 skipto 20000 all from 66.39.79.217 to any
ipfw add 101 skipto 20000 all from any to 66.39.79.217
ipfw add 102 skipto 20000 all from 69.63.190.22 to any
ipfw add 103 skipto 20000 all from any to 69.63.190.22
ipfw add 104 skipto 20000 all from 212.150.139.29 to any
ipfw add 105 skipto 20000 all from any to 212.150.139.29
ipfw add 106 skipto 20000 all from 62.0.18.221 to any
ipfw add 107 skipto 20000 all from any to 62.0.18.221
ipfw add 108 skipto 20000 all from 65.55.17.27 to any
ipfw add 109 skipto 20000 all from any to 65.55.17.27
ipfw add 110 skipto 20000 all from 184.73.110.30 to any
ipfw add 111 skipto 20000 all from any to 184.73.110.30

ipfw pipe 1 config delay 0ms bw 10240Kbit/s mask all
ipfw pipe 2 config delay 0ms bw 10240Kbit/s mask all
ipfw add pipe 1 ip from any to any in
ipfw add pipe 2 ip from any to any out

