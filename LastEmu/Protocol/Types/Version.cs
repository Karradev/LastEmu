using Protocol.IO;
using System;

namespace Protocol.Types
{
	public class Version
	{
		public const short Id = 11;

		public sbyte major;

		public sbyte minor;

		public sbyte release;

		public int revision;

		public sbyte patch;

		public sbyte buildType;

	    public override string ToString()
	    {
	        return $"{major}.{minor}.{release}";
	    }

	    public virtual short TypeId
		{
			get
			{
				return 11;
			}
		}

		public Version()
		{
		}

		public Version(sbyte major, sbyte minor, sbyte release, int revision, sbyte patch, sbyte buildType)
		{
			this.major = major;
			this.minor = minor;
			this.release = release;
			this.revision = revision;
			this.patch = patch;
			this.buildType = buildType;
		}

		public virtual void Deserialize(IDataReader reader)
		{
			this.major = reader.ReadSByte();
			this.minor = reader.ReadSByte();
			this.release = reader.ReadSByte();
			this.revision = reader.ReadInt();
			this.patch = reader.ReadSByte();
			this.buildType = reader.ReadSByte();
		}

		public virtual void Serialize(IDataWriter writer)
		{
			writer.WriteSByte(this.major);
			writer.WriteSByte(this.minor);
			writer.WriteSByte(this.release);
			writer.WriteInt(this.revision);
			writer.WriteSByte(this.patch);
			writer.WriteSByte(this.buildType);
		}
	}
}