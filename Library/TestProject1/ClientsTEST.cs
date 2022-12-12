using System.Reflection;
using Xunit;
using SportClub;

namespace SportClubTest;

public class ClientsTests
{
    [Fact]
    public void CreateClientsTrue()
    {
        //Arrange
        string lastName = "asdf";
        string firstName = "asdf";
        string middleName = "asdf";
        string LastName = "asdf";
        string FirstName = "asdf";
        string MiddleName = "asdf";
        string temp = $"{lastName},{firstName},{middleName},{LastName},{FirstName},{MiddleName}";
        //Act
        var coaches1 = new Coach(LastName,FirstName,MiddleName);
        var clients1 = new Clients(lastName,firstName,middleName,coaches1);
        //Assert
        Assert.Equal(clients1.ToString(),temp);
    }

    [Fact]
    public void ExceptionCreateFalse()
    {
        //Arrange
        string lastName = "asdf";
        string firstName = "asdf";
        string middleName = "asdf";
        string LastName = "asdf";
        string FirstName = "asdf";
        string MiddleName = "asdf";
        //Act
        var coaches1 = new Coach(LastName, FirstName, MiddleName);
        var clients1 = new Clients(lastName, firstName, middleName, coaches1);
        //Assert
        Assert.Throws<ArgumentNullException>(() => new Clients(lastName, null!, middleName, coaches1));
    }

    [Fact]
    public void AddCreateTrue()
    {
        //Arrange
        string lastName = "asdf";
        string firstName = "asdf";
        string middleName = "asdf";
        string LastName = "asdf";
        string FirstName = "asdf";
        string MiddleName = "asdf";
        string numTrain = "12345";
        //Act
        var training1 = new Training(numTrain);
        var coaches1 = new Coach(LastName, FirstName, MiddleName);
        var clients1 = new Clients(lastName, firstName, middleName, coaches1);
        clients1.AddTraining(training1);
        //Assert
        Assert.Equal(clients1.trainings.Contains(training1), true);
    }

}