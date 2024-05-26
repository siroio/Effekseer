#pragma once

#include "FbxLoader.h"

class FbxCurveConverter
{
private:
	static const int ConverterVersion = 1;

	static FbxNurbsCurveData* SearchNurbsCurve(const FbxNodeInfo& _pFbxeInfo);

public:
	static bool Export(const std::string& file_path, const FbxInfo& _pNodeInfo);
};
