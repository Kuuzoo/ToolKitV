#pragma once

// When including SDKDDKVer.h, the highest available Windows platform will be targeted.
// If you plan to build your application for a previous version of Windows, include WinSDKVer.h and
// set the desired platform in the _WIN32_WINNT macro before including SDKDDKVer.h.
#include <SDKDDKVer.h>

#define API_URL "https://api.umbrella.re"
#define CDN_URL "https://cdn.umbrella.re"
#define DOWNLOAD "/toolkitv/download"
#define DOWNLOAD_FILE "/toolkitv/files/"
#define GET_UPDATER "/toolkitv/updater"
#define GET_CACHES "/toolkitv/getCurrentFileCaches"
#define BACKUP_DOWNLOAD_URL "https://github.com/UmbrellaRE/ToolKitV/releases/latest/download/ToolKitV.zip"
#define PRODUCT_NAME L"ToolKitV"