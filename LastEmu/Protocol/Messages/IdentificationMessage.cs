using System;
using Protocol.IO;
using Protocol.Types;

namespace Protocol.Messages
{
    public class IdentificationMessage : NetworkMessage
    {
        public const uint Id = 4;

        public bool Autoconnect;

        public sbyte[] Credentials;

        public uint[] FailedAttempts;

        public string Lang;

        public short ServerId;

        public double SessionOptionalSalt;

        public bool UseCertificate;

        public bool UseLoginToken;

        public VersionExtended Version;

        public IdentificationMessage()
        {
        }

        public IdentificationMessage(bool autoconnect, bool useCertificate, bool useLoginToken, VersionExtended version,
            string lang, sbyte[] credentials, short serverId, double sessionOptionalSalt, uint[] failedAttempts)
        {
            Autoconnect = autoconnect;
            UseCertificate = useCertificate;
            UseLoginToken = useLoginToken;
            Version = version;
            Lang = lang;
            Credentials = credentials;
            ServerId = serverId;
            SessionOptionalSalt = sessionOptionalSalt;
            FailedAttempts = failedAttempts;
        }

        public override uint ProtocolId => (uint) 4;

        public override void Deserialize(IDataReader reader)
        {
            var flag1 = reader.ReadByte();
            Autoconnect = BooleanByteWrapper.GetFlag(flag1, 0);
            UseCertificate = BooleanByteWrapper.GetFlag(flag1, 1);
            UseLoginToken = BooleanByteWrapper.GetFlag(flag1, 2);
            Version = new VersionExtended();
            Version.Deserialize(reader);
            Lang = reader.ReadUTF();
            ServerId = reader.ReadShort();
            SessionOptionalSalt = reader.ReadVarLong();

            var failLimit = reader.ReadShort();
            for (var i = 0; i < failLimit; i++)
                FailedAttempts[i] = (uint) reader.ReadVarShort();
        }

        public override void Serialize(IDataWriter writer)
        {
            var num = BooleanByteWrapper.SetFlag(0, 0, Autoconnect);
            num = BooleanByteWrapper.SetFlag(num, 1, UseCertificate);
            writer.WriteByte(BooleanByteWrapper.SetFlag(num, 2, UseLoginToken));
            Version.Serialize(writer);
            writer.WriteUTF(Lang);
            writer.WriteVarInt(Credentials.Length);
            var numArray = Credentials;
            foreach (var t in numArray)
            {
                writer.WriteSByte(t);
            }
            writer.WriteShort(ServerId);
            writer.WriteVarLong(SessionOptionalSalt);
            writer.WriteShort((short) FailedAttempts.Length);
            var numArray1 = FailedAttempts;
            foreach (var t in numArray1)
            {
                writer.WriteVarShort((int) t);
            }
        }
    }
}