﻿// <copyright file="ValidateControlExtensions.SpellCheck.cs" company="Automate The Planet Ltd.">
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
using System;
using Bellatrix.Web.Contracts;
using Bellatrix.Web.Events;

namespace Bellatrix.Web
{
    public static partial class ValidateControlExtensions
    {
        public static void ValidateSpellCheckIsNull<T>(this T control, int? timeout = null, int? sleepInterval = null)
            where T : IComponentSpellCheck, IComponent
        {
            WaitUntil(() => control.SpellCheck == null, $"The control's spellcheck should be null but was '{control.SpellCheck}'.", timeout, sleepInterval);
            ValidatedSpellCheckIsNullEvent?.Invoke(control, new ComponentActionEventArgs(control));
        }

        public static void ValidateSpellCheckIs<T>(this T control, string value, int? timeout = null, int? sleepInterval = null)
            where T : IComponentSpellCheck, IComponent
        {
            WaitUntil(() => control.SpellCheck.Equals(value), $"The control's spellcheck should be '{value}' but was '{control.SpellCheck}'.", timeout, sleepInterval);
            ValidatedSpellCheckIsEvent?.Invoke(control, new ComponentActionEventArgs(control, value));
        }

        public static event EventHandler<ComponentActionEventArgs> ValidatedSpellCheckIsNullEvent;
        public static event EventHandler<ComponentActionEventArgs> ValidatedSpellCheckIsEvent;
    }
}