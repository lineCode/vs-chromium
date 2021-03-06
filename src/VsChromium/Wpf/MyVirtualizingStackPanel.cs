// Copyright 2013 The Chromium Authors. All rights reserved.
// Use of this source code is governed by a BSD-style license that can be
// found in the LICENSE file.

using System.Windows.Controls;

namespace VsChromium.Wpf {
  public class MyVirtualizingStackPanel : VirtualizingStackPanel {
    public void BringIntoView(int index) {
      BringIndexIntoView(index);
    }
  }
}
