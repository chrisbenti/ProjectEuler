$sum = 0
(1..999) | ? { ($_ % 3 -eq 0) -or ($_ % 5 -eq 0) } | % {
    $sum += $_
}

Write-Host "Sum: $sum"
