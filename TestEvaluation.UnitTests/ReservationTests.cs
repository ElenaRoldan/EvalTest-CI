using EvaluationTests;

namespace TestEvaluation.UnitTests;

[TestClass]
public class ReservationTests
{
    [TestMethod]
    public void CanBeCancelledByUser_WithUser_ReturnTrue()
    {
        var user = new User();
        var reservation = new Reservation(user);
        var result = reservation.CanBeCancelledBy(user);
        
        Assert.IsTrue(result);
    }
    [TestMethod]
    public void CanBeCancelledByUser_WithAdmin_ReturnTrue()
    {
        var user = new User();
        var admin = new User { IsAdmin = true };
        var reservation = new Reservation(admin);
        var result = reservation.CanBeCancelledBy(admin);
        
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void CanBeCancelledByUser_WithUser_ReturnFalse()
    {
        var user = new User();
        var notUser= new User();
        var reservation = new Reservation(user);
        var result = reservation.CanBeCancelledBy(notUser);
        Assert.IsFalse(result);
    }
    [TestMethod]
    public void CanBeCancelledByUser_WithAdmin_ReturnFalse()
    {
        var user = new User();
        var notAdmin = new User {IsAdmin = false};
        var reservation = new Reservation(user);
        var result = reservation.CanBeCancelledBy(notAdmin);
        Assert.IsFalse(result);
    }
}