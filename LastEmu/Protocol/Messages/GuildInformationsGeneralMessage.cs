using Protocol.IO;

using System;

namespace Protocol.Messages
{
	public class GuildInformationsGeneralMessage : NetworkMessage
	{
		public const uint Id = 5557;

		public bool abandonnedPaddock;

		public byte level;

		public double expLevelFloor;

		public double experience;

		public double expNextLevelFloor;

		public int creationDate;

		public uint nbTotalMembers;

		public uint nbConnectedMembers;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5557;
			}
		}

		public GuildInformationsGeneralMessage()
		{
		}

		public GuildInformationsGeneralMessage(bool abandonnedPaddock, byte level, double expLevelFloor, double experience, double expNextLevelFloor, int creationDate, uint nbTotalMembers, uint nbConnectedMembers)
		{
			this.abandonnedPaddock = abandonnedPaddock;
			this.level = level;
			this.expLevelFloor = expLevelFloor;
			this.experience = experience;
			this.expNextLevelFloor = expNextLevelFloor;
			this.creationDate = creationDate;
			this.nbTotalMembers = nbTotalMembers;
			this.nbConnectedMembers = nbConnectedMembers;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.abandonnedPaddock = reader.ReadBoolean();
			this.level = reader.ReadByte();
			this.expLevelFloor = reader.ReadVarUhLong();
			this.experience = reader.ReadVarUhLong();
			this.expNextLevelFloor = reader.ReadVarUhLong();
			this.creationDate = reader.ReadInt();
			this.nbTotalMembers = reader.ReadVarUhShort();
			this.nbConnectedMembers = reader.ReadVarUhShort();
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteBoolean(this.abandonnedPaddock);
			writer.WriteByte(this.level);
			writer.WriteVarLong(this.expLevelFloor);
			writer.WriteVarLong(this.experience);
			writer.WriteVarLong(this.expNextLevelFloor);
			writer.WriteInt(this.creationDate);
			writer.WriteVarShort((int)this.nbTotalMembers);
			writer.WriteVarShort((int)this.nbConnectedMembers);
		}
	}
}