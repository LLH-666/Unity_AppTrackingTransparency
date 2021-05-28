# Unity_AppTrackingTransparency
App Tracking Transparency For Unity - IOS 14 IDFA

根据IOS14 最新推出的隐私追踪规则，添加相应的弹窗显示

加入插件后，在XCode打包时,在Info.plist中加入下面字段，后面的文字则是显示追踪弹窗时显示的文案
···
<key>NSUserTrackingUsageDescription</key>
<string>We need to use your ad tracking permission to track ads</string>
···
