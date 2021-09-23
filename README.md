### Repro steps

1) Run the app
2) Open `Views/Home/Index.cshtml` and update it:

```diff
- @ViewBag.Test2
+ @ViewBag.Test
```
3) Open `Controllers/HomeController.cs` and update it:

```diff
public IActionResult Index()
{
-   ViewBag.Test2 = "value1";
+   ViewBag.Test = "value1";
    return View();
}
```
4) Click apply changes


