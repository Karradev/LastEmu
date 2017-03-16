using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class PaddockContentInformations : PaddockInformations
	{
		public const short Id = 183;

		public int paddockId;

		public short worldX;

		public short worldY;

		public int mapId;

		public uint subAreaId;

		public bool abandonned;

		public MountInformationsForPaddock[] mountsInformations;

		public override short TypeId
		{
			get
			{
				return 183;
			}
		}

		public PaddockContentInformations()
		{
		}

		public PaddockContentInformations(uint maxOutdoorMount, uint maxItems, int paddockId, short worldX, short worldY, int mapId, uint subAreaId, bool abandonned, MountInformationsForPaddock[] mountsInformations) : base(maxOutdoorMount, maxItems)
		{
			this.paddockId = paddockId;
			this.worldX = worldX;
			this.worldY = worldY;
			this.mapId = mapId;
			this.subAreaId = subAreaId;
			this.abandonned = abandonned;
			this.mountsInformations = mountsInformations;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.paddockId = reader.ReadInt();
			this.worldX = reader.ReadShort();
			this.worldY = reader.ReadShort();
			this.mapId = reader.ReadInt();
			this.subAreaId = reader.ReadVarUhShort();
			this.abandonned = reader.ReadBoolean();
			ushort num = reader.ReadUShort();
			this.mountsInformations = new MountInformationsForPaddock[num];
			for (int i = 0; i < num; i++)
			{
				this.mountsInformations[i] = new MountInformationsForPaddock();
				this.mountsInformations[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			writer.WriteInt(this.paddockId);
			writer.WriteShort(this.worldX);
			writer.WriteShort(this.worldY);
			writer.WriteInt(this.mapId);
			writer.WriteVarShort((int)this.subAreaId);
			writer.WriteBoolean(this.abandonned);
			writer.WriteShort((short)((int)this.mountsInformations.Length));
			MountInformationsForPaddock[] mountInformationsForPaddockArray = this.mountsInformations;
			for (int i = 0; i < (int)mountInformationsForPaddockArray.Length; i++)
			{
				mountInformationsForPaddockArray[i].Serialize(writer);
			}
		}
	}
}