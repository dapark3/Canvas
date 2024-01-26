namespace DomainModel;

public class Assignment
{
    private string assignmentName;

    private string assignmentInfo;

    private string submissionStatus;

    private int pointsValue;

    private int pointsEarned;

    private string dueDate;

    private string dateSubmitted;

    private string timeSubmitted;

    private List<string> submissionComments;

    private List<string> viewSubmissionComments(){
        return submissionComments;
    }

    private void uploadFile(string filePath) {
        
    }

    private void submit() {

    }
}