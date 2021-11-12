function sub(e) {
    e.preventDefault();
    var a, b, c, d, e, f, sum, avg;
    a = (document.getElementById('name').value);
    b = parseFloat(document.getElementById('tam').value);
    c = parseFloat(document.getElementById('eng').value);
    d = parseFloat(document.getElementById('mat').value);
    e = parseFloat(document.getElementById('scs').value);
    f = parseFloat(document.getElementById('cpm').value);
    sum = b + c + d + e + f;
    avg = sum / 5;

    var newTable = document.getElementById('Tablescore');
    var row = newTable.insertRow(-1);
    var cell1 = row.insertCell(0);
    var cell2 = row.insertCell(0);
    var cell3 = row.insertCell(0);
    var cell4 = row.insertCell(0);


    cell4.innerHTML = a;
    cell3.innerHTML = sum;
    cell2.innerHTML = avg;

    if (avg >= 45) {
        cell1.innerHTML = "<font color=green>Pass</font>";
    } else {
        cell1.innerHTML = "<font color=Red>Fail</font>";
    }
}