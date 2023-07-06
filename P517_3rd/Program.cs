//int[] MergeArray(int[] arr1, int[] arr2)
//{
//    int[] newArr = new int[0];
//    for (int i = 0; i < arr1.Length; i++)
//    {
//        for (int j = 0; j < arr2.Length; j++)
//        {
//            if (arr1[i] == arr2[j])
//            {
//                Array.Resize(ref newArr,newArr.Length+1);
//                newArr[newArr.Length - 1] = arr1[i];
//                break;
//            }
//        }
//    }

//    return newArr;
//}

int[] MergeArray(int[] arr1, int[] arr2)
{
    int index = 0;

    int length = arr1.Length;
    if (arr1.Length > arr2.Length)
    {
        length = arr2.Length;
    }

    int[] merged = new int[length];
    for (int i = 0; i < arr1.Length; i++)
    {
        for (int j = 0; j < arr2.Length; j++)
        {
            if (arr1[i] == arr2[j])
            {
                merged[index] = arr1[i];
                index++;
                break;
            }
        }

    }
    Array.Resize(ref merged, index-1);
    return merged;
}


//Search
//Linear Search
//Binary Search

// {3, 6, 7, 9, 11, 3, -6}  7

//void LinearSearch(int[] arr, int target)
//{
//    int position = -1;

//    for (int i = 0; i < arr.Length; i++)
//    {
//        if (arr[i] == target)
//        {
//            position = i;
//            break;
//        }
//    }
//    if (position == -1)
//    {
//        Console.WriteLine("Target not found");
//    }
//    else
//    {
//        Console.WriteLine("Target found in {0} position", position);
//    }
//}

//LinearSearch(new int[] { 3, 6, 7, 9 }, 6);

void LinearSearch(int[] array, int target)
{
    bool flag = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == target)
        {
            flag = true;
            Console.WriteLine("Target found at index {0}", i);
        }
    }
    if (!flag)
    {
        Console.WriteLine("Target not found");
    }
}


int BinarySearch(int[]arr, int num)
{
    int start = 0;
    int end = arr.Length - 1;
    Array.Sort(arr);
    while (start<=end)
    {
        int mid = (start + end) / 2;
      
        if (num == arr[mid])
        {
            return mid;
        }
        else if(num < arr[mid])
        {
            end = mid - 1;
        }
        else
        {
            start = mid + 1;
        }
    }
    return -1;
}
//int pos = BinarySearch(new int[]{1, 5, 6, 8, 2, 4, 7}, -8);

//if (pos == -1)
//{
//    Console.WriteLine("Target not found");
//}
//else
//{
//   Console.WriteLine("Target found in {0} position", pos);

//}


int[] DoubleArray(int[] arr)
{
    //arr (5,1,9,7) -- 4
    //doubleArr(5,1,9,7,5,1,9,7) -- 8
    int[] doubleArr = new int[arr.Length*2];
    for (int i = 0; i < arr.Length; i++)
    {
        doubleArr[i] = arr[i];
        doubleArr[i + arr.Length] = arr[i];
    }
    return doubleArr;
}
//int[] doubleArray = DoubleArray(new int[] { 5, 1, 9, 7 });
//foreach (var item in doubleArray)
//{
//    Console.WriteLine(item);
//}
// arr-{ 5, 1, 9, 7 }
// target - 8
// output-{1,3}


int[] TwoSum(int[] arr, int target)
{
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[i] + arr[j] == target)
            {
                return new int[2]{ i,j};
            }
        }
    }
    return new int[2];
}

//int[] sum = TwoSum(new int[] {0,3,1,5,7,8},8);
//foreach (var item in sum)
//{
//    Console.WriteLine(item);
//}

int[] SomeArray(int[] array)
{
    int[] someArr = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            someArr[i] += array[j];
        }
    }
    return someArr;
}

//foreach (var i in SomeArray(new[] { 1, 2, 3, 4 }))
//{
//    Console.WriteLine(i);
//}

int[] SumsOfIndex(int[] nums)
{
    int sum = 0;
    for (int i = 0; i < nums.Length; i++)
    {
        sum += nums[i];
        nums[i] = sum;
    }
    return nums;
}
foreach (var item in SumsOfIndex(new int[] { 1, 5,7, 4 }))
{
    Console.WriteLine(item);
}




Console.ReadLine();

