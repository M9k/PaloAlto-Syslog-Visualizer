# PaloAlto-syslog-visualizer
Tools to replace the Monitor tab for Palo Alto 410, using syslog log forwardin.
To use it configure a syslog forwarding for the traffic to the IP of your PC (please check that the firewall allow the traffic if you aren't on the same net of the management interface).
It use the standard port UDP 514.

**Run it as amministrator!**

![Screenshot](https://github.com/M9k/PaloAlto-syslog-visualizer/blob/master/Screenshot2.jpg?raw=true)

![Screenshot](https://github.com/M9k/PaloAlto-syslog-visualizer/blob/master/Screenshot.png?raw=true)


The program has a circular buffer of 50000 entry, the search show the last 50 events that match the search filter.
it is possible to deny the search by checking the box next to the text box.

It use at max 120Mb of ram when the buffer is full and the CPU usage is minimal.


## Limitation
- Some data from the original syslog aren't considered and saved. If you think something important is missing, please tell me.
The complete field list is documented here: [Palo Alto Traffic log fields](https://docs.paloaltonetworks.com/pan-os/10-1/pan-os-admin/monitoring/use-syslog-for-monitoring/syslog-field-descriptions/traffic-log-fields.html)
- The flags are shown "as is", without analyzing the meaning of the fields.
- There is no pagination, only the last 50 entry that match the filter are show.
- Only traffic logs are supported for now.
- Search is only possible on certain fields for now
- Only for Windows.
- I don't have a logo for the icon.
