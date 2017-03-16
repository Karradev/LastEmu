using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class TaxCollectorAttackedMessage : NetworkMessage
	{
		public const uint Id = 5918;

		public uint firstNameId;

		public uint lastNameId;

		public short worldX;

		public short worldY;

		public int mapId;

		public uint subAreaId;

		public BasicGuildInformations guild;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5918;
			}
		}

		public TaxCollectorAttackedMessage()
		{
		}

		public TaxCollectorAttackedMessage(uint firstNameId, uint lastNameId, short worldX, short worldY, int mapId, uint subAreaId, BasicGuildInformations guild)
		{
			this.firstNameId = firstNameId;
			this.lastNameId = lastNameId;
			this.worldX = worldX;
			this.worldY = worldY;
			this.mapId = mapId;
			this.subAreaId = subAreaId;
			this.guild = guild;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.firstNameId = reader.ReadVarUhShort();
			this.lastNameId = reader.ReadVarUhShort();
			this.worldX = reader.ReadShort();
			this.worldY = reader.ReadShort();
			this.mapId = reader.ReadInt();
			this.subAreaId = reader.ReadVarUhShort();
			this.guild = new BasicGuildInformations();
			this.guild.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteVarShort((int)this.firstNameId);
			writer.WriteVarShort((int)this.lastNameId);
			writer.WriteShort(this.worldX);
			writer.WriteShort(this.worldY);
			writer.WriteInt(this.mapId);
			writer.WriteVarShort((int)this.subAreaId);
			this.guild.Serialize(writer);
		}
	}
}