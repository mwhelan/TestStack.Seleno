﻿using NSubstitute;
using TestStack.Seleno.Tests.TestObjects;

namespace TestStack.Seleno.Tests.Configuration.SelenoHost
{
    class When_navigating_to_initial_page_from_Url : SelenoHostSpecification
    {
        private const string Url = "/Host/SomeUrl";

        public void Given_the_Seleno_Application_is_configured()
        {
            SUT.Run(c => {});
        }
        
        public void When_navigating_to_initial_page()
        {
            SUT.NavigateToInitialPage<TestPage>(Url);
        }

        public void Then_it_should_navigate_using_the_seleno_application()
        {
            SelenoApplication.Received().NavigateToInitialPage<TestPage>(Url);
        }
    }
}