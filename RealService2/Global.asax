﻿<%@ Application Language="C#" %>

<script runat="server">

    void Application_Start(object sender, EventArgs e) 
    {
        Application["Count"] = 0;

    }
    
    void Application_End(object sender, EventArgs e) 
    {
        //  Code that runs on application shutdown

    }
        
    void Application_Error(object sender, EventArgs e) 
    {
        Exception objErr = Server.GetLastError().GetBaseException();
        string err = "Error Caught in Application_Error event\n" +
                "Error in: " + Request.Url.ToString() +
                "\nError Message:" + objErr.Message.ToString() +
                "\nStack Trace:" + objErr.StackTrace.ToString();
        System.Diagnostics.EventLog.WriteEntry("RealReport", err, System.Diagnostics.EventLogEntryType.Error);
        Response.Redirect(DirectoryPaths.GENERIC_ERROR);
        Server.ClearError();
    }

    void Session_Start(object sender, EventArgs e) 
    {
        // Code that runs when a new session is started

    }

    void Session_End(object sender, EventArgs e) 
    {
        // Code that runs when a session ends. 
        // Note: The Session_End event is raised only when the sessionstate mode
        // is set to InProc in the Web.config file. If session mode is set to StateServer 
        // or SQLServer, the event is not raised.

    }
       
</script>
