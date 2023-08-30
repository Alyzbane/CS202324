import json
"""
    format: Map[k,v(tuples)]
    ["TIME", [["Weekday(Monday,...)", "LINK", "SUBJECT/CODE"]
"""
# Iterate over the meetings variable
def meeting_parser(meetings_file):
    # Create a dictionary to store the meetings
    meetings_dict = {}

    # Read the sorted meetings dictionary from a file
    with open("meetings.json", "r") as f:
        meetings_dict = json.load(f)

    for weekday, time, link, subject in meetings_json:
    # Create a key-value pair in the dictionary
        if weekday not in meetings_dict:
            meetings_dict[weekday] = []
        meetings_dict[weekday].append((time,link,subject))

    # Sort the dictionary by the meeting time
    return meetings_dict

def meetings_feeder():
    # Write the sorted meetings dictionary to a file
    sorted_meetings_dict = sorted(meetings_dict.items())
    with open("meetings.json", "w") as f:
        json.dump(sorted_meetings_dict, f)



