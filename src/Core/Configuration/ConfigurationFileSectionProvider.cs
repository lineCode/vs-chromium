﻿// Copyright 2013 The Chromium Authors. All rights reserved.
// Use of this source code is governed by a BSD-style license that can be
// found in the LICENSE file.

using System;
using System.Collections.Generic;

namespace VsChromium.Core.Configuration {
  public class ConfigurationFileSectionProvider : IConfigurationSectionProvider {
    private readonly IConfigurationFileProvider _configurationFileProvider;

    public ConfigurationFileSectionProvider(IConfigurationFileProvider configurationFileProvider) {
      _configurationFileProvider = configurationFileProvider;
    }

    public IEnumerable<string> GetSection(string name, Func<IEnumerable<string>, IEnumerable<string>> postProcessing) {
      return _configurationFileProvider.ReadFile(name, postProcessing);
    }
  }
}
