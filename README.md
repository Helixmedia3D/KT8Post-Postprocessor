# KT8Post-Postprocessor
Post-Postprocessor voor KT8 DUAL+ 3D printer om gereedschapswissel mogelijk te maken.<br>
Download een precompiled versie of compile zelf met [.NET framework](https://www.microsoft.com/net/download)  

# KT8 DUAL+ Instellingen
## Cura 15.04 
### start2.gcode
```gcode
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
```
### end2.gcode
```gcode
M104 T0 S0
M104 T1 S0
M140 S0
M42 P57 S0 ;fan 1730 off
M42 P58 S0 ;fan e3d off
M42 P5 S0 ;heated chamber off
G91
G1 E-1 F300
G1 Z+0.5 E-5 X-20 Y-20 F{travel_speed}
G28 X0 Y0
M84
G90
;{profile_string}
```

