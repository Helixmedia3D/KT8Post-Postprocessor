# KT8Post-Postprocessor
Post-Postprocessor voor KT8 DUAL+ 3D printer om gereedschapswissel mogelijk te maken.<br>
Download een precompiled versie of compile zelf met [.NET framework](https://www.microsoft.com/net/download)  

# KT8 DUAL+ Instellingen
'
G21        
G90        
M107       
G28
G29
G1 Z15.0 F{travel_speed}
T1
G92 E0
G1 F200 E10
G92 E0
G1 F200 E-{retraction_dual_amount}
T0
G92 E0
G1 F200 E10
G92 E0
G1 F{travel_speed}
M117 HEATING CHAMBER
;CHAMBERTEMP
;OPWARMDWELL
;SPEED1730
;SPEEDE3D
M117 KT8 DUAL+
;STARTTOOL
'
