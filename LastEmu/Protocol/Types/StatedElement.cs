using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class StatedElement
	{
		public const short Id = 108;

		public int elementId;

		public uint elementCellId;

		public uint elementState;

		public bool onCurrentMap;

		public virtual short TypeId
		{
			get
			{
				return 108;
			}
		}

		public StatedElement()
		{
		}

		public StatedElement(int elementId, uint elementCellId, uint elementState, bool onCurrentMap)
		{
			this.elementId = elementId;
			this.elementCellId = elementCellId;
			this.elementState = elementState;
			this.onCurrentMap = onCurrentMap;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.elementId = reader.ReadInt();
			this.elementCellId = reader.ReadVarUhShort();
			this.elementState = reader.ReadVarUhInt();
			this.onCurrentMap = reader.ReadBoolean();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteInt(this.elementId);
			writer.WriteVarShort((int)this.elementCellId);
			writer.WriteVarInt((int)this.elementState);
			writer.WriteBoolean(this.onCurrentMap);
		}
	}
}