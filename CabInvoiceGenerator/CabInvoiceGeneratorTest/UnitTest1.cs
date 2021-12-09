using CabInvoiceGenerator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CabInvoiceGeneratorTest
{
    [TestClass]
    public class UnitTest1
    {

        InvoiceGenerator invoiceGenerator = null;
        [TestMethod]
        public void GivenDistanceAndTimeShouldTotalFare()
        {
            invoiceGenerator = new InvoiceGenerator(RideType.Normal);
            double distance = 2.0;
            int time = 5;
            double fare = invoiceGenerator.CalcaulateFare(distance, time);
            double expected = 25;

            Assert.AreEqual(expected, fare);

        }


        [TestMethod]
        public void GivenMultipleRidesShouldReturnInvoiceSummary()
        {
            invoiceGenerator = new InvoiceGenerator(RideType.Normal);
            Ride[] rides = { new Ride(2.0, 5), new Ride(0.1, 1) };

            InvoiceSummary summary = invoiceGenerator.CalcaulateFare(rides);
            InvoiceSummary excpectedSummary = new InvoiceSummary(2, 30.0);

            Assert.AreEqual(excpectedSummary, summary);
        }
    }
}
