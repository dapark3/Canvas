```mermaid
classDiagram
    User -- Dashboard: Views
    User -- Calendar: Views
    User -- Inbox: Views
    Dashboard --> Course: Holds
    Course --> Event: Creates
    Course |--> Assignment: Assigns
    Event <--| Calendar: Displays
    Course |--> Discussion: Assigns
    Inbox <|-- Message: Displays


    class User{
        +email : string
        +fullName : string
	    -bsuID : int
        -profileInfo : list<string>
        -updateSettings()
        -updateProfile()
    }
    
    class Inbox {
        -totalMessages : int
        -messages : list<string>
        -searchMessages(string)
        -searchUserByName(string)
        -sendMessage()
        -deleteMessage()
    }

    class Message {
        -sender : string
        -recipients : list<string>
        -dateSent : int
        -timeSent: string
        -messageHeader : string
        -messageContent : string
        -reply(string)
        -forward(string)
        -delete()
    }

    class Calendar {
        +month : string
        +day : int
        +year : int
        +calendars : list<string>
        -events : list<Event>
        +editEvent(Event)
        +deleteEvent(Event)
        +addEvent()
        +viewEventInfo(Event)
    }

    class Event {
        +day: int
        +timeStart: string
        +timeEnd: string
        +header: string
        +description: string
    }

    class Dashboard {
        -courseList : list<string>
        -announcmentHeader : list<string>
        +viewAnnouncements()
        +viewCourseInfo(string)
    }

    class Course {
        +courseDepartment : string
        +courseNumber : int
        +sectionNumber : int
        +courseName : string
        +instructorName : string
        +assignments: list[Assignment]
        +announcements: list[string]
        +people: list[User]
        +groups: list[string]
        +modules : list[string]
        -viewAssignments()
        -viewGrades()
        -viewModules()
        -viewAnnouncments()
        -viewClassmates()
        -viewGroupMembers()
    }

    class Assignment {
        -assignmentName : string
        -assignmentInfo : string
        -submissionStatus : string
        -pointsValue : int
        -pointsEarned : int
        -dueDate : int
        -dateSubmitted : int
        -timeSubmitted : string
        -submissionComments : int
        -viewSubmissionComments()
        -uploadFile(file)
        -submit()
    }

    class Discussion {
        -discussionName: string
        -discussionPost: string
        -responsePosts : list<string>
        -submissionStatus : string
        -dueDate : int
        -pointsValue : int
        -pointsEarned : int
        -dueDate : int
        -dateSubmitted : int
        -timeSubmitted : string
        -reply(post)
    }