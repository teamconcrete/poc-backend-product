using MongoDB.Driver;
using Moq;
using Ecommerce.Data.MongoDB;
using Xunit;

namespace Ecommerce.Data.Tests
{
    public class MongoWrapperTests
    {
        private MockRepository _mockRepository;
        private Mock<MongoSettings> _mongoSettings;
        private Mock<IMongoClient> _mongoClient;
        private MongoWrapper _mongoWrapper;

        public MongoWrapperTests()
        {
            _mockRepository = new MockRepository(MockBehavior.Strict);
            _mongoSettings = _mockRepository.Create<MongoSettings>("some:connection", "database");
            _mongoClient = _mockRepository.Create<IMongoClient>();
            _mongoWrapper = new MongoWrapper(_mongoSettings.Object, _mongoClient.Object);

            _mongoClient.Setup(x => x.GetDatabase(_mongoSettings.Object.Database, null)).Returns(It.IsAny<IMongoDatabase>());
        }

        [Fact]
        public void GetDatabase_ShouldReturnSuccessfully()
        {
            //TODO: Find a way to validate the database creation
            var database = _mongoWrapper.GetDatabase();
        }
    }
}
