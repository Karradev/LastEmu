using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class Preset
	{
		public const short Id = 355;

		public sbyte presetId;

		public sbyte symbolId;

		public bool mount;

		public PresetItem[] objects;

		public virtual short TypeId
		{
			get
			{
				return 355;
			}
		}

		public Preset()
		{
		}

		public Preset(sbyte presetId, sbyte symbolId, bool mount, PresetItem[] objects)
		{
			this.presetId = presetId;
			this.symbolId = symbolId;
			this.mount = mount;
			this.objects = objects;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.presetId = reader.ReadSByte();
			this.symbolId = reader.ReadSByte();
			this.mount = reader.ReadBoolean();
			ushort num = reader.ReadUShort();
			this.objects = new PresetItem[num];
			for (int i = 0; i < num; i++)
			{
				this.objects[i] = new PresetItem();
				this.objects[i].Deserialize(reader);
			}
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.presetId);
			writer.WriteSByte(this.symbolId);
			writer.WriteBoolean(this.mount);
			writer.WriteShort((short)((int)this.objects.Length));
			PresetItem[] presetItemArray = this.objects;
			for (int i = 0; i < (int)presetItemArray.Length; i++)
			{
				presetItemArray[i].Serialize(writer);
			}
		}
	}
}