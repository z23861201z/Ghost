﻿
namespace Server.Common.Net
{
    public enum InteroperabilityMessage : ushort
    {
        RegistrationRequest,
        RegistrationResponse,

        LoadProportionRequest,
        LoadProportionResponse,

        CharacterEntriesRequest,
        CharacterEntriesResponse,

        CharacterNameCheckRequest,
        CharacterNameCheckResponse,

        CharacterCreationRequest,
        CharacterCreationResponse,

        CharacterDeletionRequest,
        CharacterDeletionResponse,

        CharPortRequest,
        CharPortResponse,

        GamePortRequest,
        GamePortResponse,

        MessagePortRequest,
        MessagePortResponse,

        ShopPortRequest,
        ShopPortResposne,

        WhisperFindRequest,
        WhisperFindResult
    }

    public enum ClientMessage : ushort
    {
        // Login
        LOGIN_SERVER = 0x55AA,
        LOGIN_REQ = 0x30,
        SERVERLIST_REQ = 0x32,
        GAME_REQ = 0x34,

        // Char
        MYCHAR_INFO_REQ = 0x8,
        CREATE_MYCHAR_REQ = 0xA,
        CHECK_SAMENAME_REQ = 0xC,
        DELETE_MYCHAR_REQ = 0xE
    }

    public enum ServerMessage : ushort
    {
        // Login
        LOGIN_ACK = 0x31,
        SERVERLIST_ACK = 0x33,
        GAME_ACK = 0x35,

        // Char
        MYCHAR_INFO_ACK = 0x9,
        CREATE_MYCHAR_ACK = 0xB,
        CHECK_SAMENAME_ACK = 0xD,
        DELETE_MYCHAR_ACK = 0xF
    }
}
