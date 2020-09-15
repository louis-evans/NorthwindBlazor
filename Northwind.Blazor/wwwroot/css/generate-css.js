const { exec } = require("child_process");

exec("sass ./sass/site.scss site.css", (err, stdout, stderr) =>
{
    if (err)
    {
        console.error("Error: generated site.css", err);
    }
    else
    {
        console.log("generated site.css");
    }
});


exec("sass ./bootstrap/bootstrap.custom.scss ./bootstrap/bootstrap.css", (err, stdout, stderr) =>
{
    if (err)
    {
        console.error("Error: generated bootstrap.css", err);
    }
    else
    {
        console.log("generated bootstrap.css");
    }
});