using System;
using TechTalk.SpecFlow;
using Xunit;

namespace GameCore.Specs
{
    [Binding]
    public class PlayerCharacterSteps
    {

        private PlayerCharacter _player;

        [Given(@"I am a new player")]
        public void GivenIamANewPlayer()
        {
            this._player = new PlayerCharacter();
        }
        
        [When(@"I take (.*) damage")]
        public void WhenITakeDamage(int p0)
        {
            _player.Hit(0);
        }
        
        [Then(@"My health should be (.*)")]
        public void ThenMyHealthShouldBe(int p0)
        {
            Assert.Equal(100, _player.Health);
        }
    }
}
