int addDigits(int num) {
    // base case
    if (num < 10) return num;
    // recursive case
    int temp_sum = 0;
    while (num > 0) {
        temp_sum += num % 10;
        num /= 10;
    }

    return addDigits(temp_sum);
}