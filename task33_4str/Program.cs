﻿bool IsInArray(int[] array, int target)
{
for (int i = 0; i < array.Length; i++)
{
if (array[i] == target)
{
return true;
}
}
return false;
}