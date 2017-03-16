using Protocol.IO;


using System;

namespace Protocol.Messages
{
	public class AccountCapabilitiesMessage : NetworkMessage
	{
		public const uint Id = 6216;

		public bool tutorialAvailable;

		public bool canCreateNewCharacter;

		public int accountId;

		public uint breedsVisible;

		public uint breedsAvailable;

		public sbyte status;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6216;
			}
		}

		public AccountCapabilitiesMessage()
		{
		}

		public AccountCapabilitiesMessage(bool tutorialAvailable, bool canCreateNewCharacter, int accountId, uint breedsVisible, uint breedsAvailable, sbyte status)
		{
			this.tutorialAvailable = tutorialAvailable;
			this.canCreateNewCharacter = canCreateNewCharacter;
			this.accountId = accountId;
			this.breedsVisible = breedsVisible;
			this.breedsAvailable = breedsAvailable;
			this.status = status;
		}

		public override void Deserialize(IDataReader reader)
		{
			byte num = reader.ReadByte();
			this.tutorialAvailable = BooleanByteWrapper.GetFlag(num, 0);
			this.canCreateNewCharacter = BooleanByteWrapper.GetFlag(num, 1);
			this.accountId = reader.ReadInt();
			this.breedsVisible = reader.ReadVarUhInt();
			this.breedsAvailable = reader.ReadVarUhInt();
			this.status = reader.ReadSByte();
		}

		public override void Serialize(IDataWriter writer)
		{
			byte num = BooleanByteWrapper.SetFlag(0, 0, this.tutorialAvailable);
			writer.WriteByte(BooleanByteWrapper.SetFlag(num, 1, this.canCreateNewCharacter));
			writer.WriteInt(this.accountId);
			writer.WriteVarInt((int)this.breedsVisible);
			writer.WriteVarInt((int)this.breedsAvailable);
			writer.WriteSByte(this.status);
		}
	}
}