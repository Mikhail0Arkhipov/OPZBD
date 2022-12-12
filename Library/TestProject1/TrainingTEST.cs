using System.Reflection;
using Xunit;
using SportClub;

namespace SportClubTest;

public class TrainingTests
{
    [Fact]
    public void CreateTrainingTrue()
    {
        //Arrange
        string numTrain = "12345";
        string temp = $"{numTrain}";
        //Act
        var training1 = new Training(numTrain);
        //Assert
        Assert.Equal(training1.ToString(), temp);
    }

    [Fact]
    public void ExceptionCreateFalse()
    {
        //Arrange
        string numTrain = "12345";
        //Act
        var training1 = new Training(numTrain);
        //Assert
        Assert.Throws<ArgumentNullException>(() => new Training(null!));
    }
}
