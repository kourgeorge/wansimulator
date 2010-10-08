@set CYGWIN=nodosfilewarning
@ipfw -q flush
@ipfw -q pipe flush
ipfw add 100 skipto 20000 all from 1.1.1.1 to any
ipfw add 101 skipto 20000 all from any to 1.1.1.1
ipfw add 102 skipto 20000 all from 2.2.2.2 to any
ipfw add 103 skipto 20000 all from any to 2.2.2.2
ipfw add 104 skipto 20000 all from 3.3.3.3 to any
ipfw add 105 skipto 20000 all from any to 3.3.3.3
ipfw add 106 skipto 20000 all from 4.4.44.4 to any
ipfw add 107 skipto 20000 all from any to 4.4.44.4

ipfw pipe 1 config delay 0ms bw 1024Kbit/s mask all
ipfw pipe 2 config delay 0ms bw 1024Kbit/s mask all
ipfw add pipe 1 ip from any to any in
ipfw add pipe 2 ip from any to any out

