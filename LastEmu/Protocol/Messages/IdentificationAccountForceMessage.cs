using Protocol.IO;
using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class IdentificationAccountForceMessage : IdentificationMessage
	{
		public const uint Id = 6119;

		public string forcedAccountLogin;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6119;
			}
		}

		public IdentificationAccountForceMessage()
		{
		}

		public IdentificationAccountForceMessage(bool autoconnect, bool useCertificate, bool useLoginToken, VersionExtended version, string lang, sbyte[] credentials, short serverId, double sessionOptionalSalt, uint[] failedAttempts, string forcedAccountLogin) : base(autoconnect, useCertificate, useLoginToken, version, lang, credentials, serverId, sessionOptionalSalt, failedAttempts)
		{
			this.forcedAccountLogin = forcedAccountLogin;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.forcedAccountLogin = reader.ReadUTF();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteUTF(this.forcedAccountLogin);
		}
	}
}