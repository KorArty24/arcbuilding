using NUnit.Framework;
using WindowsFormsApp1.Arc;

namespace ArcBuilding.Test
{
    public class Tests
    {
        private ArcDTO _dto;
        private TArc _arc;
        [SetUp]
        public void Setup()
        {
             _dto = new ArcDTO
            {
                span = 18000,
                height = 7500,
                innerRadiusOffset = 1200,
                numPanels = 6,
            };
            _arc = new TArc();
        }

        [Test]
        public void ShouldReturnCoordinates_R()
        {
            //Act
            _arc.BuildArc(_dto);
            //Assert
            Assert.True(_dto.span == 18000);


        }
    }
}