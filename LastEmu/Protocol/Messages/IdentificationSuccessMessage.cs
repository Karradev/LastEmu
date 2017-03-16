using Protocol.IO;


using System;

namespace Protocol.Messages
{
	public class IdentificationSuccessMessage : NetworkMessage
	{
		public const uint Id = 22;

		public bool hasRights;

		public bool wasAlreadyConnected;

		public string login;

		public string nickname;

		public int accountId;

		public sbyte communityId;

		public string secretQuestion;

		public double accountCreation;

		public double subscriptionElapsedDuration;

		public double subscriptionEndDate;

		public byte havenbagAvailableRoom;

		public override uint ProtocolId
		{
			get
			{
				return (uint)22;
			}
		}

		public IdentificationSuccessMessage()
		{
		}

		public IdentificationSuccessMessage(bool hasRights, bool wasAlreadyConnected, string login, string nickname, int accountId, sbyte communityId, string secretQuestion, double accountCreation, double subscriptionElapsedDuration, double subscriptionEndDate, byte havenbagAvailableRoom)
		{
			this.hasRights = hasRights;
			this.wasAlreadyConnected = wasAlreadyConnected;
			this.login = login;
			this.nickname = nickname;
			this.accountId = accountId;
			this.communityId = communityId;
			this.secretQuestion = secretQuestion;
			this.accountCreation = accountCreation;
			this.subscriptionElapsedDuration = subscriptionElapsedDuration;
			this.subscriptionEndDate = subscriptionEndDate;
			this.havenbagAvailableRoom = havenbagAvailableRoom;
		}

		public override void Deserialize(IDataReader reader)
		{
			byte num = reader.ReadByte();
			this.hasRights = BooleanByteWrapper.GetFlag(num, 0);
			this.wasAlreadyConnected = BooleanByteWrapper.GetFlag(num, 1);
			this.login = reader.ReadUTF();
			this.nickname = reader.ReadUTF();
			this.accountId = reader.ReadInt();
			this.communityId = reader.ReadSByte();
			this.secretQuestion = reader.ReadUTF();
			this.accountCreation = reader.ReadDouble();
			this.subscriptionElapsedDuration = reader.ReadDouble();
			this.subscriptionEndDate = reader.ReadDouble();
			this.havenbagAvailableRoom = reader.ReadByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			byte num = BooleanByteWrapper.SetFlag(0, 0, this.hasRights);
			writer.WriteByte(BooleanByteWrapper.SetFlag(num, 1, this.wasAlreadyConnected));
			writer.WriteUTF(this.login);
			writer.WriteUTF(this.nickname);
			writer.WriteInt(this.accountId);
			writer.WriteSByte(this.communityId);
			writer.WriteUTF(this.secretQuestion);
			writer.WriteDouble(this.accountCreation);
			writer.WriteDouble(this.subscriptionElapsedDuration);
			writer.WriteDouble(this.subscriptionEndDate);
			writer.WriteByte(this.havenbagAvailableRoom);
		}
	}
}