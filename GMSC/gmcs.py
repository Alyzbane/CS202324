import webbrowser
import ctypes
import time
from datetime import datetime
from just_playback import Playback


""" GM-SC : Good Morning - Sexy Computer """
notif = Playback('./nrs.mp3')
notif.set_volume(1)
notif.play();
ctypes.windll.user32.MessageBoxW(0, "GM-SC", 'CS-3A', 0x1000) # refer to docs

# Define a function to open a link
def open_link(link, code, weekday):
    notif.set_volume(1)
    notif.play();
    ctypes.windll.user32.MessageBoxW(0, f'{weekday} - {code}!!!', 'GM-CSOP' , 0x1000) # refer to docs
    webbrowser.open_new_tab(link)

"""BSCS-3A
    SUBJECTS: 3
    CLASSES: 13 incl. LABS
    LABS: 2 T, F
"""

meetings = {
    "Monday": [
        ("07:25", "meet.google.com/byj-aycr-svi", "ADVSTA+"),
        ("11:55", "meet.google.com/nnm-zfhg-fmm", "GEEMIND")
    ],
    "Tuesday": [
        ("07:25", "meet.google.com/jzd-afrx-pay", "GEARTS+"),
        ("13:25", "meet.google.com/ysv-udjd-hzy", "CSOS101"),
        ("16:25", "meet.google.com/ysv-udjd-hzy", "CSOS101")
    ],
    "Wednesday": [
        ("07:25", "meet.google.com/fwy-zsja-iez", "CALPH++"),
        ("11:55", "meet.google.com/awg-rjvf-nhq", "CSPL101"),
        ("14:55", "meet.google.com/efz-pqwf-tpi", "LINALGE"),
        ("20:06", "meet.google.com/efz-pqwf-tpi", "LINALGE")
    ],
    "Friday": [
        ("20:06", "meet.google.com/efz-pqwf-tpi", "LINALGE"),
        ("07:25", "meet.google.com/nbg-osdp-woc", "CSDS102"),
        ("10:25", "meet.google.com/nex-dwpy-unm", "ADVSTA+"),
        ("14:55", "meet.google.com/awg-rjvf-nhq", "CSPL101")
    ],
    "Saturday": [
        ("09:55", "meet.google.com/hdh-hajn-zbg", "CSHCI01"),
        ("16:25", "meet.google.com/hdh-hajn-zbg", "CSHCI01")
    ]
}
while True:
    now = datetime.now()
    weekday = now.strftime('%A')
    ntime = now.strftime('%H:%M')

    if weekday in meetings:
        print(f"Weekday: {weekday}, Time: {ntime}")
        
        meeting_list = meetings.get(weekday, [])
        
        matching_meetings = [meeting for meeting in meeting_list if meeting[0] == ntime]
        
        for meeting_time, link, code in matching_meetings:
            print(f"Time: {meeting_time}, Link: {link}, Code: {code}")
            open_link(link, code, weekday)
            break

    time.sleep(60) # Wait a minute before checking again
