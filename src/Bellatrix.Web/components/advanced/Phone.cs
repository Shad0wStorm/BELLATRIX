﻿// <copyright file="Phone.cs" company="Automate The Planet Ltd.">
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
using System.Diagnostics;
using Bellatrix.Web.Contracts;
using Bellatrix.Web.Events;

namespace Bellatrix.Web;

public class Phone : Component, IComponentDisabled, IComponentValue, IComponentPhone, IComponentAutoComplete, IComponentReadonly, IComponentRequired, IComponentMaxLength, IComponentMinLength, IComponentSize, IComponentPlaceholder
{
    public static event EventHandler<ComponentActionEventArgs> Hovering;
    public static event EventHandler<ComponentActionEventArgs> Hovered;
    public static event EventHandler<ComponentActionEventArgs> SettingPhone;
    public static event EventHandler<ComponentActionEventArgs> PhoneSet;

    public override Type ComponentType => GetType();

    public virtual string GetPhone()
    {
        return DefaultGetValue();
    }

    public virtual void SetPhone(string phone)
    {
        SetValue(SettingPhone, PhoneSet, phone);
    }

    public virtual void Hover()
    {
        Hover(Hovering, Hovered);
    }

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public virtual bool IsDisabled => GetDisabledAttribute();

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public virtual string Value => DefaultGetValue();

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public virtual bool IsAutoComplete => GetAutoCompleteAttribute();

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public virtual bool IsReadonly => GetReadonlyAttribute();

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public virtual bool IsRequired => GetRequiredAttribute();

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public virtual string Placeholder => GetPlaceholderAttribute();

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public virtual int? MaxLength => DefaultGetMaxLength();

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public virtual int? MinLength => DefaultGetMinLength();

    [DebuggerBrowsable(DebuggerBrowsableState.Never)]
    public virtual new int? Size => GetSizeAttribute();
}