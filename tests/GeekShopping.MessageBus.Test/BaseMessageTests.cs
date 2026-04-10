namespace GeekShopping.MessageBus.Test
{
    public class BaseMessageTests
    {
        [Fact]
        public void PublicMessage_ShouldThrowException_WhenQueueNameIsEmpty()
        {
            //Arrange
            var message = new BaseMessage();
            var testId = 10;
            var testDate = DateTime.Now;

            //Act
            message.Id = testId;
            message.MessageCreated = testDate;

            //Assert

            Assert.Equal(testId, message.Id);
            Assert.Equal(testDate, message.MessageCreated);
        }
    }
}