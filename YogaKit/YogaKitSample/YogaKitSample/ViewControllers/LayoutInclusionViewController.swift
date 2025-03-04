/*
 * This file provided by Facebook is for non-commercial testing and evaluation
 * purposes only.  Facebook reserves all rights not expressly granted.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
 * FACEBOOK BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN
 * ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
 * CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
 */

import UIKit
import YogaKit

final class LayoutInclusionViewController: UIViewController {
    private let button: UIButton = UIButton(type: .system)
    private let disappearingView: UIView = UIView(frame: .zero)
    private let contentView: UIView = UIView(frame: .zero)

    override func viewDidLoad() {
        let root = self.view!
        root.backgroundColor = .white
        root.configureLayout { (layout) in
            layout.isEnabled = true
            layout.flexDirection = .column
            layout.justifyContent = .spaceAround
        }

        contentView.backgroundColor = .clear
        contentView.layer.borderColor = UIColor.lightGray.cgColor
        contentView.layer.borderWidth = 1.0
        contentView.configureLayout { (layout) in
            layout.isEnabled = true
            layout.height = 300
            layout.width = YGValue(self.view.bounds.size.width)
            layout.flexDirection = .row
            layout.justifyContent = .center
            layout.paddingHorizontal = 25
        }
        self.view.addSubview(contentView)

        let redView = UIView(frame: .zero)
        redView.backgroundColor = .red
        redView.configureLayout { (layout) in
            layout.isEnabled = true
            layout.flexGrow = 1
            layout.flexShrink = 1
        }
        contentView.addSubview(redView)

        disappearingView.backgroundColor = .blue
        disappearingView.configureLayout { (layout) in
            layout.isEnabled = true
            layout.flexGrow = 1
        }
        contentView.addSubview(disappearingView)

        button.setTitle("Add Blue View", for: UIControlState.selected)
        button.setTitle("Remove Blue View", for: UIControlState.normal)
        button.addTarget(self, action: #selector(buttonWasTapped), for: UIControlEvents.touchUpInside)
        button.configureLayout { (layout) in
            layout.isEnabled = true
            layout.height = 300
            layout.width = 300
            layout.alignSelf = .center
        }
        root.addSubview(button)

        root.yoga.applyLayout(preservingOrigin: false)
    }

    // MARK - UIButton Action
    func buttonWasTapped() {
        button.isSelected = !button.isSelected

        button.isUserInteractionEnabled = false
        disappearingView.yoga.isIncludedInLayout = !disappearingView.yoga.isIncludedInLayout
        disappearingView.isHidden = !disappearingView.isHidden

        contentView.yoga.applyLayout(preservingOrigin: true)
        button.isUserInteractionEnabled = true
    }
}
