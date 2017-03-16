using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class IdentificationSuccessWithLoginTokenMessage : IdentificationSuccessMessage
	{
		public const uint Id = 6209;

		public string loginToken;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6209;
			}
		}

		public IdentificationSuccessWithLoginTokenMessage()
		{
		}

		public IdentificationSuccessWithLoginTokenMessage(bool hasRights, bool wasAlreadyConnected, string login, string nickname, int accountId, sbyte communityId, string secretQuestion, double accountCreation, double subscriptionElapsedDuration, double subscriptionEndDate, byte havenbagAvailableRoom, string loginToken) : base(hasRights, wasAlreadyConnected, login, nickname, accountId, communityId, secretQuestion, accountCreation, subscriptionElapsedDuration, subscriptionEndDate, havenbagAvailableRoom)
		{
			this.loginToken = loginToken;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.loginToken = reader.ReadUTF();
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteUTF(this.loginToken);
		}
	}
}