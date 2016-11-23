/**
 * Copyright (c) 2014-present, Facebook, Inc.
 * All rights reserved.
 *
 * This source code is licensed under the BSD-style license found in the
 * LICENSE file in the root directory of this source tree. An additional grant
 * of patent rights can be found in the PATENTS file in the same directory.
 */

 // @Generated by gentest/gentest.rb from gentest/fixtures/CSSLayoutFlexWrapTest.html

using System;
using NUnit.Framework;

namespace Facebook.CSSLayout
{
    [TestFixture]
    public class CSSLayoutFlexWrapTest
    {
        [Test]
        public void Test_wrap_column()
        {
            CSSNode root = new CSSNode();
            root.Wrap = CSSWrap.Wrap;
            root.StyleHeight = 100f;

            CSSNode root_child0 = new CSSNode();
            root_child0.StyleWidth = 30f;
            root_child0.StyleHeight = 30f;
            root.Insert(0, root_child0);

            CSSNode root_child1 = new CSSNode();
            root_child1.StyleWidth = 30f;
            root_child1.StyleHeight = 30f;
            root.Insert(1, root_child1);

            CSSNode root_child2 = new CSSNode();
            root_child2.StyleWidth = 30f;
            root_child2.StyleHeight = 30f;
            root.Insert(2, root_child2);

            CSSNode root_child3 = new CSSNode();
            root_child3.StyleWidth = 30f;
            root_child3.StyleHeight = 30f;
            root.Insert(3, root_child3);
            root.StyleDirection = CSSDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(60f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(0f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(30f, root_child0.LayoutWidth);
            Assert.AreEqual(30f, root_child0.LayoutHeight);

            Assert.AreEqual(0f, root_child1.LayoutX);
            Assert.AreEqual(30f, root_child1.LayoutY);
            Assert.AreEqual(30f, root_child1.LayoutWidth);
            Assert.AreEqual(30f, root_child1.LayoutHeight);

            Assert.AreEqual(0f, root_child2.LayoutX);
            Assert.AreEqual(60f, root_child2.LayoutY);
            Assert.AreEqual(30f, root_child2.LayoutWidth);
            Assert.AreEqual(30f, root_child2.LayoutHeight);

            Assert.AreEqual(30f, root_child3.LayoutX);
            Assert.AreEqual(0f, root_child3.LayoutY);
            Assert.AreEqual(30f, root_child3.LayoutWidth);
            Assert.AreEqual(30f, root_child3.LayoutHeight);

            root.StyleDirection = CSSDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(60f, root.LayoutWidth);
            Assert.AreEqual(100f, root.LayoutHeight);

            Assert.AreEqual(30f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(30f, root_child0.LayoutWidth);
            Assert.AreEqual(30f, root_child0.LayoutHeight);

            Assert.AreEqual(30f, root_child1.LayoutX);
            Assert.AreEqual(30f, root_child1.LayoutY);
            Assert.AreEqual(30f, root_child1.LayoutWidth);
            Assert.AreEqual(30f, root_child1.LayoutHeight);

            Assert.AreEqual(30f, root_child2.LayoutX);
            Assert.AreEqual(60f, root_child2.LayoutY);
            Assert.AreEqual(30f, root_child2.LayoutWidth);
            Assert.AreEqual(30f, root_child2.LayoutHeight);

            Assert.AreEqual(0f, root_child3.LayoutX);
            Assert.AreEqual(0f, root_child3.LayoutY);
            Assert.AreEqual(30f, root_child3.LayoutWidth);
            Assert.AreEqual(30f, root_child3.LayoutHeight);
        }

        [Test]
        public void Test_wrap_row()
        {
            CSSNode root = new CSSNode();
            root.FlexDirection = CSSFlexDirection.Row;
            root.Wrap = CSSWrap.Wrap;
            root.StyleWidth = 100f;

            CSSNode root_child0 = new CSSNode();
            root_child0.StyleWidth = 30f;
            root_child0.StyleHeight = 30f;
            root.Insert(0, root_child0);

            CSSNode root_child1 = new CSSNode();
            root_child1.StyleWidth = 30f;
            root_child1.StyleHeight = 30f;
            root.Insert(1, root_child1);

            CSSNode root_child2 = new CSSNode();
            root_child2.StyleWidth = 30f;
            root_child2.StyleHeight = 30f;
            root.Insert(2, root_child2);

            CSSNode root_child3 = new CSSNode();
            root_child3.StyleWidth = 30f;
            root_child3.StyleHeight = 30f;
            root.Insert(3, root_child3);
            root.StyleDirection = CSSDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(60f, root.LayoutHeight);

            Assert.AreEqual(0f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(30f, root_child0.LayoutWidth);
            Assert.AreEqual(30f, root_child0.LayoutHeight);

            Assert.AreEqual(30f, root_child1.LayoutX);
            Assert.AreEqual(0f, root_child1.LayoutY);
            Assert.AreEqual(30f, root_child1.LayoutWidth);
            Assert.AreEqual(30f, root_child1.LayoutHeight);

            Assert.AreEqual(60f, root_child2.LayoutX);
            Assert.AreEqual(0f, root_child2.LayoutY);
            Assert.AreEqual(30f, root_child2.LayoutWidth);
            Assert.AreEqual(30f, root_child2.LayoutHeight);

            Assert.AreEqual(0f, root_child3.LayoutX);
            Assert.AreEqual(30f, root_child3.LayoutY);
            Assert.AreEqual(30f, root_child3.LayoutWidth);
            Assert.AreEqual(30f, root_child3.LayoutHeight);

            root.StyleDirection = CSSDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(60f, root.LayoutHeight);

            Assert.AreEqual(70f, root_child0.LayoutX);
            Assert.AreEqual(0f, root_child0.LayoutY);
            Assert.AreEqual(30f, root_child0.LayoutWidth);
            Assert.AreEqual(30f, root_child0.LayoutHeight);

            Assert.AreEqual(40f, root_child1.LayoutX);
            Assert.AreEqual(0f, root_child1.LayoutY);
            Assert.AreEqual(30f, root_child1.LayoutWidth);
            Assert.AreEqual(30f, root_child1.LayoutHeight);

            Assert.AreEqual(10f, root_child2.LayoutX);
            Assert.AreEqual(0f, root_child2.LayoutY);
            Assert.AreEqual(30f, root_child2.LayoutWidth);
            Assert.AreEqual(30f, root_child2.LayoutHeight);

            Assert.AreEqual(70f, root_child3.LayoutX);
            Assert.AreEqual(30f, root_child3.LayoutY);
            Assert.AreEqual(30f, root_child3.LayoutWidth);
            Assert.AreEqual(30f, root_child3.LayoutHeight);
        }

        [Test]
        public void Test_wrap_row_align_items_flex_end()
        {
            CSSNode root = new CSSNode();
            root.FlexDirection = CSSFlexDirection.Row;
            root.AlignItems = CSSAlign.FlexEnd;
            root.Wrap = CSSWrap.Wrap;
            root.StyleWidth = 100f;

            CSSNode root_child0 = new CSSNode();
            root_child0.StyleWidth = 30f;
            root_child0.StyleHeight = 10f;
            root.Insert(0, root_child0);

            CSSNode root_child1 = new CSSNode();
            root_child1.StyleWidth = 30f;
            root_child1.StyleHeight = 20f;
            root.Insert(1, root_child1);

            CSSNode root_child2 = new CSSNode();
            root_child2.StyleWidth = 30f;
            root_child2.StyleHeight = 30f;
            root.Insert(2, root_child2);

            CSSNode root_child3 = new CSSNode();
            root_child3.StyleWidth = 30f;
            root_child3.StyleHeight = 30f;
            root.Insert(3, root_child3);
            root.StyleDirection = CSSDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(60f, root.LayoutHeight);

            Assert.AreEqual(0f, root_child0.LayoutX);
            Assert.AreEqual(20f, root_child0.LayoutY);
            Assert.AreEqual(30f, root_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child0.LayoutHeight);

            Assert.AreEqual(30f, root_child1.LayoutX);
            Assert.AreEqual(10f, root_child1.LayoutY);
            Assert.AreEqual(30f, root_child1.LayoutWidth);
            Assert.AreEqual(20f, root_child1.LayoutHeight);

            Assert.AreEqual(60f, root_child2.LayoutX);
            Assert.AreEqual(0f, root_child2.LayoutY);
            Assert.AreEqual(30f, root_child2.LayoutWidth);
            Assert.AreEqual(30f, root_child2.LayoutHeight);

            Assert.AreEqual(0f, root_child3.LayoutX);
            Assert.AreEqual(30f, root_child3.LayoutY);
            Assert.AreEqual(30f, root_child3.LayoutWidth);
            Assert.AreEqual(30f, root_child3.LayoutHeight);

            root.StyleDirection = CSSDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(60f, root.LayoutHeight);

            Assert.AreEqual(70f, root_child0.LayoutX);
            Assert.AreEqual(20f, root_child0.LayoutY);
            Assert.AreEqual(30f, root_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child0.LayoutHeight);

            Assert.AreEqual(40f, root_child1.LayoutX);
            Assert.AreEqual(10f, root_child1.LayoutY);
            Assert.AreEqual(30f, root_child1.LayoutWidth);
            Assert.AreEqual(20f, root_child1.LayoutHeight);

            Assert.AreEqual(10f, root_child2.LayoutX);
            Assert.AreEqual(0f, root_child2.LayoutY);
            Assert.AreEqual(30f, root_child2.LayoutWidth);
            Assert.AreEqual(30f, root_child2.LayoutHeight);

            Assert.AreEqual(70f, root_child3.LayoutX);
            Assert.AreEqual(30f, root_child3.LayoutY);
            Assert.AreEqual(30f, root_child3.LayoutWidth);
            Assert.AreEqual(30f, root_child3.LayoutHeight);
        }

        [Test]
        public void Test_wrap_row_align_items_center()
        {
            CSSNode root = new CSSNode();
            root.FlexDirection = CSSFlexDirection.Row;
            root.AlignItems = CSSAlign.Center;
            root.Wrap = CSSWrap.Wrap;
            root.StyleWidth = 100f;

            CSSNode root_child0 = new CSSNode();
            root_child0.StyleWidth = 30f;
            root_child0.StyleHeight = 10f;
            root.Insert(0, root_child0);

            CSSNode root_child1 = new CSSNode();
            root_child1.StyleWidth = 30f;
            root_child1.StyleHeight = 20f;
            root.Insert(1, root_child1);

            CSSNode root_child2 = new CSSNode();
            root_child2.StyleWidth = 30f;
            root_child2.StyleHeight = 30f;
            root.Insert(2, root_child2);

            CSSNode root_child3 = new CSSNode();
            root_child3.StyleWidth = 30f;
            root_child3.StyleHeight = 30f;
            root.Insert(3, root_child3);
            root.StyleDirection = CSSDirection.LTR;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(60f, root.LayoutHeight);

            Assert.AreEqual(0f, root_child0.LayoutX);
            Assert.AreEqual(10f, root_child0.LayoutY);
            Assert.AreEqual(30f, root_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child0.LayoutHeight);

            Assert.AreEqual(30f, root_child1.LayoutX);
            Assert.AreEqual(5f, root_child1.LayoutY);
            Assert.AreEqual(30f, root_child1.LayoutWidth);
            Assert.AreEqual(20f, root_child1.LayoutHeight);

            Assert.AreEqual(60f, root_child2.LayoutX);
            Assert.AreEqual(0f, root_child2.LayoutY);
            Assert.AreEqual(30f, root_child2.LayoutWidth);
            Assert.AreEqual(30f, root_child2.LayoutHeight);

            Assert.AreEqual(0f, root_child3.LayoutX);
            Assert.AreEqual(30f, root_child3.LayoutY);
            Assert.AreEqual(30f, root_child3.LayoutWidth);
            Assert.AreEqual(30f, root_child3.LayoutHeight);

            root.StyleDirection = CSSDirection.RTL;
            root.CalculateLayout();

            Assert.AreEqual(0f, root.LayoutX);
            Assert.AreEqual(0f, root.LayoutY);
            Assert.AreEqual(100f, root.LayoutWidth);
            Assert.AreEqual(60f, root.LayoutHeight);

            Assert.AreEqual(70f, root_child0.LayoutX);
            Assert.AreEqual(10f, root_child0.LayoutY);
            Assert.AreEqual(30f, root_child0.LayoutWidth);
            Assert.AreEqual(10f, root_child0.LayoutHeight);

            Assert.AreEqual(40f, root_child1.LayoutX);
            Assert.AreEqual(5f, root_child1.LayoutY);
            Assert.AreEqual(30f, root_child1.LayoutWidth);
            Assert.AreEqual(20f, root_child1.LayoutHeight);

            Assert.AreEqual(10f, root_child2.LayoutX);
            Assert.AreEqual(0f, root_child2.LayoutY);
            Assert.AreEqual(30f, root_child2.LayoutWidth);
            Assert.AreEqual(30f, root_child2.LayoutHeight);

            Assert.AreEqual(70f, root_child3.LayoutX);
            Assert.AreEqual(30f, root_child3.LayoutY);
            Assert.AreEqual(30f, root_child3.LayoutWidth);
            Assert.AreEqual(30f, root_child3.LayoutHeight);
        }

    }
}
