﻿// <copyright file="ByAutomationId.cs" company="Automate The Planet Ltd.">
// Copyright 2022 Automate The Planet Ltd.
// Licensed under the Apache License, Version 2.0 (the "License");
// You may not use this file except in compliance with the License.
// You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
// <author>Anton Angelov</author>
// <site>https://bellatrix.solutions/</site>
using System.Collections.Generic;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;

namespace Bellatrix.Desktop.Locators;

public class FindAutomationIdStrategy : FindStrategy
{
    public FindAutomationIdStrategy(string name)
        : base(name)
    {
    }

    public override WindowsElement FindElement(WindowsDriver<WindowsElement> searchContext)
    {
        return searchContext.FindElementByAccessibilityId(Value);
    }

    public override IEnumerable<WindowsElement> FindAllElements(WindowsDriver<WindowsElement> searchContext)
    {
        return searchContext.FindElementsByAccessibilityId(Value);
    }

    public override AppiumWebElement FindElement(WindowsElement element)
    {
        return element.FindElementByAccessibilityId(Value);
    }

    public override IEnumerable<AppiumWebElement> FindAllElements(WindowsElement element)
    {
        return element.FindElementsByAccessibilityId(Value);
    }

    public override string ToString()
    {
        return $"AutomationId = {Value}";
    }
}
