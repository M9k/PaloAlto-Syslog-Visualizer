public struct StructEntryLog
{
    public string strReceiveTime;
    public string strSourceAddress;
    public string strDestinationAddress;
    public string strNATSourceIP;
    public string strNatDestinationIP;
    public string strRuleName;
    public string strSourceUser;
    public string strApplication;
    public string strSourceZone;
    public string strDentinationZone;
    public string strInboundInterface;
    public string strOutboundInterface;
    public string strSessionID;
    public string strSourcePort;
    public string strDestinationPort;
    public string strNATSourcePort;
    public string strNATDestinationPort;
    public string strFlags;
    public string strProtocol;
    public string strAction;
    public string strBytes;
    public string strBytesSent;
    public string strBytesReceived;
    public string strPackets;
    public string strElapsedTime;
    public string strCategory;
    public string strPacketsSent;
    public string strPacketsReceived;
    public string strSessionEndReason;
    public string strActionSource;

    public StructEntryLog(string strReceiveTime, string strSourceAddress, string strDestinationAddress, string strNATSourceIP, string strNatDestinationIP, string strRuleName, string strSourceUser, string strApplication, string strSourceZone, string strDentinationZone, string strInboundInterface, string strOutboundInterface, string strSessionID, string strSourcePort, string strDestinationPort, string strNATSourcePort, string strNATDestinationPort, string strFlags, string strProtocol, string strAction, string strBytes, string strBytesSent, string strBytesReceived, string strPackets, string strElapsedTime, string strCategory, string strPacketsSent, string strPacketsReceived, string strSessionEndReason, string strActionSource)
    {
        this.strReceiveTime = strReceiveTime;
        this.strSourceAddress = strSourceAddress;
        this.strDestinationAddress = strDestinationAddress;
        this.strNATSourceIP = strNATSourceIP;
        this.strNatDestinationIP = strNatDestinationIP;
        this.strRuleName = strRuleName;
        this.strSourceUser = strSourceUser;
        this.strApplication = strApplication;
        this.strSourceZone = strSourceZone;
        this.strDentinationZone = strDentinationZone;
        this.strInboundInterface = strInboundInterface;
        this.strOutboundInterface = strOutboundInterface;
        this.strSessionID = strSessionID;
        this.strSourcePort = strSourcePort;
        this.strDestinationPort = strDestinationPort;
        this.strNATSourcePort = strNATSourcePort;
        this.strNATDestinationPort = strNATDestinationPort;
        this.strFlags = strFlags;
        this.strProtocol = strProtocol;
        this.strAction = strAction;
        this.strBytes = strBytes;
        this.strBytesSent = strBytesSent;
        this.strBytesReceived = strBytesReceived;
        this.strPackets = strPackets;
        this.strElapsedTime = strElapsedTime;
        this.strCategory = strCategory;
        this.strPacketsSent = strPacketsSent;
        this.strPacketsReceived = strPacketsReceived;
        this.strSessionEndReason = strSessionEndReason;
        this.strActionSource = strActionSource;
    }
    public object[] getAll
    {
        get {
            return new object[] { strReceiveTime, strSourceAddress, strDestinationAddress, strNATSourceIP, strNatDestinationIP, strRuleName, strSourceUser, strApplication, strSourceZone, strDentinationZone, strInboundInterface, strOutboundInterface, strSessionID, strSourcePort, strDestinationPort, strNATSourcePort, strNATDestinationPort, strFlags, strProtocol, strAction, strBytes, strBytesSent, strBytesReceived, strPackets, strElapsedTime, strCategory, strPacketsSent, strPacketsReceived, strSessionEndReason, strActionSource };
        }
    }
}