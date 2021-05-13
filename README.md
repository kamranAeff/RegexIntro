# Regular expression syntax cheatsheet
###### [Qaydalı ifadələrdə sintaksis hiylələri](https://regexr.com/)

<table style="100%">
<tbody>
<tr>
<th>Element</th>
<th>Qısa izahı</th>
</tr>
<tr>
<td>\</td>
<td>Xüsusi simvolları adi simvol kimi icra edilməyə məcbur edir</td>
</tr>
<tr>
<td>^</td>
<td>Şablonun başlanğıcı göstərir(yəni ilk simvoldan yoxlamağa məcbur edir)</td>
</tr>
<tr>
<td>$</td>
<td>Şablonun bitişini göstərir(yəni son simvoladək yoxlamağa məcbur edir)</td>
</tr>
<tr>
<td>*</td>
<td>Özündən əvvəlki simvol və ya qrupun heç olmaması və ya 1/və birdən çox olduğu hallarda istifadə edilir</td>
</tr>
<tr>
<td>+</td>
<td>Özündən əvvəlki simvol və ya qrupun bir və ya birdən çox olduğu hallarda istifadə edilir</td>
</tr>
<tr>
<td>?</td>
<td>Özündən əvvəlki simvol və ya qrupun heç olmaması və ya bir dəfə olduğu hallarda istifadə edilir</td>
</tr>
<tr>
<td>.</td>
<td>Hər hansı "bir" simvolu təmsil edir</td>
</tr>
<tr>
<td>[abc]</td>
<td>Transkripsiyaların içində olan hər hansı "bir" simvolu təmsil edir</td>
</tr>
<tr>
<td>[^abc]</td>
<td>Transkripsiyaların içində olmayan hər hansı "bir" simvolu təmsil edir</td>
</tr>
<tr>
<td>[a-z]</td>
<td>Transkripsiyada olan intervala daxil olan hər hansı "bir" simvolu təmsil edir</td>
</tr>
<tr>
<td>[^a-z]</td>
<td>Transkripsiyada olan intervala daxil olmayan hər hansı "bir" simvolu təmsil edir</td>
</tr>
<tr>
<td>x|y</td>
<td>"x" və "y" simvollarından birini təmsil edir </td>
</tr>
<tr>
<td>(pattern)</td>
<td>Qrupu təmsil edir</td>
</tr>
<tr>
<td>(?&lt;name&gt;pattern)</td>
<td>Adlı qrup yaradır</td>
</tr>
<tr>
<td>{n}</td>
<td>Özündən əvvəlki simvol və ya qrupun "n" dəfə təkrar olduğu halları təmsil edir</td>
</tr>
<tr>
<td>{n,}</td>
<td>Özündən əvvəlki simvol və ya qrupun "n" və ya daha çox dəfə təkrar olduğu halları təmsil edir</td>
</tr>
<tr>
<td>{n,m}</td>
<td>Özündən əvvəlki simvol və ya qrupun ən az "n" ,ən çox "m" dəfə təkrar olduğu halları təmsil edir</td>
</tr>
<tr>
<td>(?=…)</td>
<td>Positive lookahead (axtarış tabe olan mətndə mütləq olması lazım olan simvol və ya mətnin olmasını tələb edir)</td>
</tr>
<tr>
<td>(?!…)</td>
<td>Negative lookahead (axtarış tabe olan mətndə mütləq olması lazım olan simvol və ya mətnin olmamasını tələb edir)</td>
</tr>
<tr>
<td>(?<!-)\d</td>
<td>Negative lookahead (Qarşısında "mənfi" işarəsi olmayan bir rəqəmi təmsil edir)</td>
</tr>
<tr>
<td>(?<=-)\d</td>
<td>Positive lookahead (Qarşısında "mənfi" işarəsi olan bir rəqəmi təmsil edir)</td>
</tr>
<tr>
<td>\b</td>
<td>Sözün başlanğıc və bitiş səddini təmsil edir</td>
</tr>
<tr>
<td>\B</td>
<td>Sözün başlanğıc və bitiş səddini təmsil etmədən söz daxilində axtarışı təmsil edir</td>
</tr>
<tr>
<td>\d</td>
<td>Bir rəqəmi təmsil edir</td>
</tr>
<tr>
<td>\D</td>
<td>Rəqəm olmayan bir simvolu təmsil edir</td>
</tr>
<tr>
<td>\n  or \r\n</td>
<td>Yeni sətr təmsil edir</td>
</tr>
<tr>
<td>\s</td>
<td>Bir boşluq simvolunu təmsil edir</td>
</tr>
<tr>
<td>\S</td>
<td>Boşluq olmayan simvolu təmsil edir</td>
</tr>
<tr>
<td>\t</td>
<td>Bir tab təmsil edir</td>
</tr>
<tr>
<td>\w</td>
<td>Mətn simvollarını təmsil edir, "_" daxil olmaqla.Dİgər simvollara uyğunlaşmır</td>
</tr>
<tr>
<td>\W</td>
<td>Mətn simvollarından fərqli simvolları təmsil edir, "_" daxil deyil.Digər simvollara uyğunlaşmır</td>
</tr>
</tbody>
</table>



<h2>Top 4 Regular Expression</h2>
<table style="100%">
    <tbody>
        <tr><th>Email</th></tr>
        <tr><td>^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$</td></tr>
        <tr><th>Phone Number</th></tr>
        <tr><td></td></tr>
        <tr><th>Name</th></tr>
        <tr><td></td></tr>
        <tr><th>Password</th></tr>
        <tr><td></td></tr>
    </tbody>
</table>