# KT8Post-Postprocessor
Post-Postprocessor voor KT8 DUAL+ 3D printer om gereedschapswissel mogelijk te maken.<br>
Download een precompiled versie of compile zelf met [.NET framework](https://www.microsoft.com/net/download)  

# KT8 DUAL+ Instellingen
```javascript
G21     <br>   
G90   <br>        
M107 <br>         
G28<br>   
G29<br>   
G1 Z15.0 F{travel_speed}<br>   
T1<br>   
G92 E0<br>   
G1 F200 E10<br>   
G92 E0<br>   
G1 F200 E-{retraction_dual_amount}<br>   
T0<br>   
G92 E0<br>   
G1 F200 E10<br>   
G92 E0<br>   
G1 F{travel_speed}<br>   
M117 HEATING CHAMBER<br>   
;CHAMBERTEMP<br>   
;OPWARMDWELL<br>   
;SPEED1730<br>   
;SPEEDE3D<br>   
M117 KT8 DUAL+<br>   
;STARTTOOL<br>   
'''
