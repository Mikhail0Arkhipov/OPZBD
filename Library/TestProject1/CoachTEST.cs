using System.Reflection;
using Xunit;
using SportClub;

namespace SportClubTest;

public class CoachTests
{
    [Fact]
    public void CreateCoachTrue()
    {
        //Arrange
        string LastName = "asdf";
        string FirstName = "asdf";
        string MiddleName = "asdf";
        string temp = $"{LastName},{FirstName},{MiddleName}";
        //Act
        var coaches1 = new Coach(LastName, FirstName, MiddleName);
        //Assert
        Assert.Equal(coaches1.ToString(), temp);
    }

    [Fact]
    public void ExceptionCreateFalse()
    {
        //Arrange
        string LastName = "asdf";
        string FirstName = "asdf";
        string MiddleName = "asdf";
        //Act
        var coaches1 = new Coach(LastName, FirstName, MiddleName);
        //Assert
        Assert.Throws<ArgumentNullException>(() => new Coach(null!, FirstName, MiddleName));
    }
}
