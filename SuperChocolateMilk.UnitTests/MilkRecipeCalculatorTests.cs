namespace SuperChocolateMilk.UnitTests;

using Xunit;
using SuperChocolateMilk.Core;

public class MilkRecipeCalculatorTests
{
    
    [Fact]
    public void CalculateChocolateSyrup_RegularRichness_ReturnsTenPercentRatio()
    {
    // 1. ARRANGE
    int milkVolume = 1000;
    string richness = "REGULAR";
        
    // 2. ACT
    decimal result = MilkRecipeCalculator.CalculateChocolateSyrupRequired(milkVolume, richness);
    
    // 3. ASSERT
    Assert.Equal(100m, result);
    }
    
    [Theory]
    [InlineData(1000, "LIGHT", 75)]
    [InlineData(1000, "EXTRA", 150)]
    [InlineData(1000, "ULTRA_CHOCO", 200)]
    [InlineData(0, "REGULAR", 0)]
    public void CalculateChocolateSyrup_VariousScenarios_ReturnsExpectedAmount(
        int milkVolume, string richness, decimal expectedSyrup)
    {
        //ACT
        decimal actualResult = MilkRecipeCalculator.CalculateChocolateSyrupRequired(milkVolume, richness);

        //ASSERT
        Assert.Equal(expectedSyrup, actualResult);
    }
}