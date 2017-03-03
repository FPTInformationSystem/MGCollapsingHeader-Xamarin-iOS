echo "Hello"

rm -rf /output
mkdir output

echo "Building x86 libs"
xcodebuild -project MGCollapsingHeader.xcodeproj -target MGCollapsingHeader -sdk iphonesimulator -configuration Release clean build
cp build/Release-iphonesimulator/libMGCollapsingHeader.a output/MGCollapsingHeader-i386.a

echo "Building arm64 libs"
xcodebuild -project MGCollapsingHeader.xcodeproj -target MGCollapsingHeader -sdk iphoneos -arch arm64 -configuration Release clean build
cp build/Release-iphoneos/libMGCollapsingHeader.a output/MGCollapsingHeader-arm64.a

echo "Building armv7 libs"
xcodebuild -project MGCollapsingHeader.xcodeproj -target MGCollapsingHeader -sdk iphoneos -arch armv7 -configuration Release clean build
cp build/Release-iphoneos/libMGCollapsingHeader.a output/MGCollapsingHeader-armv7.a

echo "Building armv7s libs"
xcodebuild -project MGCollapsingHeader.xcodeproj -target MGCollapsingHeader -sdk iphoneos -arch armv7s -configuration Release clean build
cp build/Release-iphoneos/libMGCollapsingHeader.a output/MGCollapsingHeader-armv7s.a

echo "Building universal libs"
lipo -create -output output/MGCollapsingHeader-universal.a output/MGCollapsingHeader-i386.a output/MGCollapsingHeader-arm64.a output/MGCollapsingHeader-armv7.a output/MGCollapsingHeader-armv7s.a