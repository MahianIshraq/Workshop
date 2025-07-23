// ReSharper disable InconsistentNaming

namespace Workshop.Services;

public class WorkshopRootService
{
    public bool bHasAdminPrivileges = true;
    public bool bIsLoggedIn = false;
    public bool bShowSignUpWindow = false;
    public bool bShowLoginWindow = false;
    public bool bShowChatWindow = false;
    public bool bHasNotifications = true;
    public bool bShowNotificationWindow = false;
    public bool bShowCreateListingWindow = false;

    public void ResetLayout()
    {
        bHasAdminPrivileges = false;
        bIsLoggedIn = false;
        bShowSignUpWindow = false;
        bShowLoginWindow = false;
        bShowChatWindow = false;
        bShowCreateListingWindow = false;
    }

    public void OnHomeButtonPressed()
    {
        if (bIsLoggedIn)
        {
            bShowChatWindow = false;
            bShowCreateListingWindow = false;
        }
        else
        {
            ResetLayout();
        }
    }
    public void OnSignUpButtonPressed()
    {
        bShowSignUpWindow = true;
        bShowLoginWindow = false;
    }
    
    public void OnLoginButtonPressed()
    {
        bShowSignUpWindow = false;
        bShowLoginWindow = true;
    }
    
    public void OnLogoutButtonPressed()
    {
        ResetLayout();
    }

    public void OnLoginSucceeded()
    {
        bIsLoggedIn = true;
    }

    public void OnLoginFailed()
    {
        
    }
    
    public void ToggleChatWindow()
    {
        bShowChatWindow = !bShowChatWindow;
    }
    
    public void ToggleNotificationWindow()
    {
        bShowNotificationWindow = !bShowNotificationWindow;
    }

    public void ToggleCreateListingWindow()
    {
        bShowCreateListingWindow = !bShowCreateListingWindow;
    }
}