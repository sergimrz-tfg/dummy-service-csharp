using System;


public class Version {

    private const int MAJOR = 1;
    private const int MINOR = 0;
    private int PATCH = 0;

    public Version(){

    }

    public String getVersion() {
        return String.Format("You are running the version {0}.{1}.{2}", MAJOR, MINOR, PATCH);
    }

    public String upgradeVersion(){
        PATCH = PATCH + 1;
        return String.Format("Successfully upgraded the version to {0}.{1}.{2}", MAJOR, MINOR, PATCH);
    }

}