using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class AllianceInvitedMessage : NetworkMessage
	{
		public const uint Id = 6397;

		public double recruterId;

		public string recruterName;

		public BasicNamedAllianceInformations allianceInfo;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6397;
			}
		}

		public AllianceInvitedMessage()
		{
		}

		public AllianceInvitedMessage(double recruterId, string recruterName, BasicNamedAllianceInformations allianceInfo)
		{
			this.recruterId = recruterId;
			this.recruterName = recruterName;
			this.allianceInfo = allianceInfo;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.recruterId = reader.ReadVarUhLong();
			this.recruterName = reader.ReadUTF();
			this.allianceInfo = new BasicNamedAllianceInformations();
			this.allianceInfo.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarLong(this.recruterId);
			writer.WriteUTF(this.recruterName);
			this.allianceInfo.Serialize(writer);
		}
	}
}